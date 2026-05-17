using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Clinic_Management_System
{
    public static class DatabaseHelper
    {
        private static readonly string DbFile = "clinic.db";
        private static readonly string ConnectionString = $"Data Source={DbFile};Version=3;";

        static DatabaseHelper()
        {
            InitializeDatabase();
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            bool needsRecreation = false;
            if (File.Exists(DbFile))
            {
                try
                {
                    using (var conn = new SQLiteConnection(ConnectionString))
                    {
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            // Validate Invoices
                            cmd.CommandText = "SELECT Amount FROM Invoices LIMIT 1;";
                            cmd.ExecuteNonQuery();

                            // Validate Consultations
                            cmd.CommandText = "SELECT ConsultationDate, DoctorID FROM Consultations LIMIT 1;";
                            cmd.ExecuteNonQuery();

                            // Validate Prescriptions
                            cmd.CommandText = "SELECT MedicationList FROM Prescriptions LIMIT 1;";
                            cmd.ExecuteNonQuery();

                            // Validate Inventory
                            cmd.CommandText = "SELECT ItemName FROM Inventory LIMIT 1;";
                            cmd.ExecuteNonQuery();

                            // Validate Settings
                            cmd.CommandText = "SELECT ClinicName FROM Settings LIMIT 1;";
                            object nameObj = cmd.ExecuteScalar();
                            if (nameObj == null || nameObj.ToString() != "MASA Clinic Pro")
                            {
                                throw new Exception("Outdated Clinic Name");
                            }
                        }
                    }
                }
                catch
                {
                    needsRecreation = true;
                }
            }

            if (needsRecreation)
            {
                try 
                { 
                    // Terminate active connections first
                    SQLiteConnection.ClearAllPools();
                    GC.Collect();
                    GC.WaitForPendingFinalizers(); // Wait for resource release
                    File.Delete(DbFile); 
                } 
                catch { }
            }

            bool dbExists = File.Exists(DbFile);
            if (!dbExists)
            {
                SQLiteConnection.CreateFile(DbFile);
            }

            using (var conn = GetConnection())
            {
                conn.Open();

                // Create Tables
                using (var cmd = conn.CreateCommand())
                {
                    // 1. Patients Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Patients (
                            PatientID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Age INTEGER,
                            Gender TEXT,
                            Phone TEXT,
                            Address TEXT,
                            MedicalHistory TEXT
                        );";
                    cmd.ExecuteNonQuery();

                    // 2. Doctors Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Doctors (
                            DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Specialty TEXT NOT NULL,
                            Phone TEXT,
                            Email TEXT,
                            WorkHours TEXT,
                            Fee REAL DEFAULT 0.0
                        );";
                    cmd.ExecuteNonQuery();

                    // 3. Appointments Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Appointments (
                            AppointmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                            PatientID INTEGER,
                            DoctorID INTEGER,
                            AppointmentDate TEXT NOT NULL,
                            AppointmentTime TEXT NOT NULL,
                            VisitType TEXT,
                            Status TEXT DEFAULT 'Pending',
                            FOREIGN KEY(PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE,
                            FOREIGN KEY(DoctorID) REFERENCES Doctors(DoctorID) ON DELETE CASCADE
                        );";
                    cmd.ExecuteNonQuery();

                    // 4. Consultations Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Consultations (
                            ConsultationID INTEGER PRIMARY KEY AUTOINCREMENT,
                            AppointmentID INTEGER,
                            PatientID INTEGER,
                            DoctorID INTEGER,
                            Complaint TEXT,
                            ChiefComplaint TEXT,
                            Diagnosis TEXT,
                            Treatment TEXT,
                            TreatmentPlan TEXT,
                            Notes TEXT,
                            BP TEXT,
                            Vitals_BP TEXT,
                            Temp TEXT,
                            Vitals_Temp TEXT,
                            Weight TEXT,
                            Vitals_Weight TEXT,
                            ConsultationDate TEXT,
                            FOREIGN KEY(AppointmentID) REFERENCES Appointments(AppointmentID) ON DELETE SET NULL,
                            FOREIGN KEY(PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE,
                            FOREIGN KEY(DoctorID) REFERENCES Doctors(DoctorID) ON DELETE SET NULL
                        );";
                    cmd.ExecuteNonQuery();

                    // 5. Prescriptions Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Prescriptions (
                            PrescriptionID INTEGER PRIMARY KEY AUTOINCREMENT,
                            PatientID INTEGER,
                            DoctorID INTEGER,
                            PrescriptionDate TEXT,
                            MedicationList TEXT,
                            Notes TEXT,
                            FOREIGN KEY(PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE,
                            FOREIGN KEY(DoctorID) REFERENCES Doctors(DoctorID) ON DELETE SET NULL
                        );";
                    cmd.ExecuteNonQuery();

                    // 6. Invoices Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Invoices (
                            InvoiceID INTEGER PRIMARY KEY AUTOINCREMENT,
                            AppointmentID INTEGER,
                            PatientID INTEGER,
                            ServiceName TEXT,
                            Price REAL DEFAULT 0.0,
                            Discount REAL DEFAULT 0.0,
                            TotalAmount REAL DEFAULT 0.0,
                            Amount REAL DEFAULT 0.0,
                            PaymentMethod TEXT,
                            IsPaid INTEGER DEFAULT 1,
                            CreatedAt TEXT,
                            InvoiceDate TEXT,
                            FOREIGN KEY(AppointmentID) REFERENCES Appointments(AppointmentID) ON DELETE SET NULL,
                            FOREIGN KEY(PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE
                        );";
                    cmd.ExecuteNonQuery();

                    // 7. Payments Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Payments (
                            PaymentID INTEGER PRIMARY KEY AUTOINCREMENT,
                            InvoiceID INTEGER,
                            AmountPaid REAL,
                            PaymentDate TEXT,
                            PaymentMethod TEXT,
                            FOREIGN KEY(InvoiceID) REFERENCES Invoices(InvoiceID) ON DELETE CASCADE
                        );";
                    cmd.ExecuteNonQuery();

                    // 8. Inventory Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Inventory (
                            ItemID INTEGER PRIMARY KEY AUTOINCREMENT,
                            DrugName TEXT NOT NULL,
                            ItemName TEXT NOT NULL,
                            Category TEXT,
                            Quantity INTEGER DEFAULT 0,
                            ExpiryDate TEXT,
                            AlertLevel INTEGER DEFAULT 10,
                            MinAlertQty INTEGER DEFAULT 10
                        );";
                    cmd.ExecuteNonQuery();

                    // 9. Users Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT UNIQUE NOT NULL,
                            Password TEXT NOT NULL,
                            Role TEXT DEFAULT 'Staff'
                        );";
                    cmd.ExecuteNonQuery();

                    // 10. Settings Table
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Settings (
                            SettingID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ClinicName TEXT NOT NULL,
                            LogoPath TEXT,
                            ContactInfo TEXT,
                            ClinicPhone TEXT,
                            ClinicAddress TEXT,
                            ThemeMode TEXT DEFAULT 'Light'
                        );";
                    cmd.ExecuteNonQuery();
                }

                // If DB is newly created, inject rich seed data
                if (!dbExists)
                {
                    SeedData(conn);
                }
            }
        }

        private static void SeedData(SQLiteConnection conn)
        {
            string todayStr = DateTime.Today.ToString("yyyy-MM-dd");

            using (var transaction = conn.BeginTransaction())
            {
                using (var cmd = conn.CreateCommand())
                {
                    // 1. Seed Settings
                    cmd.CommandText = @"
                        INSERT INTO Settings (ClinicName, ContactInfo, ClinicPhone, ClinicAddress, ThemeMode) 
                        VALUES ('MASA Clinic Pro', '+20 2 1234567', '+20 2 1234567', 'القاهرة، مصر', 'Light');";
                    cmd.ExecuteNonQuery();

                    // 2. Seed Users
                    cmd.CommandText = @"
                        INSERT INTO Users (Username, Password, Role) 
                        VALUES ('admin', 'admin123', 'Administrator'),
                               ('doctor', 'doc123', 'Doctor');";
                    cmd.ExecuteNonQuery();

                    // 3. Seed Doctors
                    cmd.CommandText = @"
                        INSERT INTO Doctors (Name, Specialty, Phone, Email, WorkHours, Fee)
                        VALUES ('Dr. Youssef Ali', 'Cardiology', '01011111111', 'youssef@masaclinic.com', '09:00 AM - 05:00 PM', 350.00),
                               ('Dr. Ahmed Salem', 'Pediatrics', '01122222222', 'ahmed@masaclinic.com', '10:00 AM - 04:00 PM', 250.00),
                               ('Dr. Sarah Ibrahim', 'Dermatology', '01233333333', 'sarah@masaclinic.com', '12:00 PM - 06:00 PM', 300.00),
                               ('Dr. Fatima Hassan', 'General Practice', '01544444444', 'fatima@masaclinic.com', '08:00 AM - 02:00 PM', 150.00);";
                    cmd.ExecuteNonQuery();

                    // 4. Seed Patients
                    cmd.CommandText = @"
                        INSERT INTO Patients (Name, Age, Gender, Phone, Address, MedicalHistory)
                        VALUES ('Amr Nabil', 28, 'Male', '01023456789', 'Cairo, Egypt', 'No chronic illnesses'),
                               ('Fatima Ali', 34, 'Female', '01123456789', 'Giza, Egypt', 'Asthma, Penicillin Allergy'),
                               ('Khaled Omar', 45, 'Male', '01223456789', 'Alexandria, Egypt', 'Hypertension, takes Coveram'),
                               ('Mona Sayed', 19, 'Female', '01523456789', 'Maadi, Cairo', 'None'),
                               ('Tarek Mahmoud', 62, 'Male', '01098765432', 'Heliopolis, Cairo', 'Type 2 Diabetes');";
                    cmd.ExecuteNonQuery();

                    // 5. Seed Appointments
                    cmd.CommandText = $@"
                        INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, VisitType, Status)
                        VALUES (1, 1, '{todayStr}', '09:00 AM', 'Consultation', 'Confirmed'),
                               (2, 2, '{todayStr}', '09:30 AM', 'Follow-up', 'Pending'),
                               (3, 3, '{todayStr}', '10:15 AM', 'Consultation', 'Confirmed'),
                               (4, 4, '{todayStr}', '11:00 AM', 'Consultation', 'Cancelled'),
                               (5, 1, '2026-05-18', '01:00 PM', 'Consultation', 'Pending');";
                    cmd.ExecuteNonQuery();

                    // 6. Seed Consultations
                    cmd.CommandText = $@"
                        INSERT INTO Consultations (AppointmentID, PatientID, DoctorID, Complaint, ChiefComplaint, Diagnosis, Treatment, TreatmentPlan, Notes, BP, Vitals_BP, Temp, Vitals_Temp, Weight, Vitals_Weight, ConsultationDate)
                        VALUES (3, 3, 3, 'Severe chest pain during effort', 'Severe chest pain during effort', 'Stable Angina pectoris', 'Aspirin 81mg, Nitroglycerin sublingual PRN', 'Aspirin 81mg, Nitroglycerin sublingual PRN', 'Advised to avoid severe exertion, follow cardiac diet.', '135/85', '135/85', '36.8', '36.8', '84 kg', '84 kg', '{todayStr}');";
                    cmd.ExecuteNonQuery();

                    // 7. Seed Prescriptions
                    cmd.CommandText = $@"
                        INSERT INTO Prescriptions (PatientID, DoctorID, PrescriptionDate, MedicationList, Notes)
                        VALUES (3, 3, '{todayStr}', 'Aspirin 81mg - الجرعة: 1 tablet daily (Take after lunch) لمدة: 30' || char(10) || 'Concor 5mg - الجرعة: 1/2 tablet morning (Take on empty stomach) لمدة: 30', 'يُرجى المتابعة بعد شهر.');";
                    cmd.ExecuteNonQuery();

                    // 8. Seed Invoices & Payments (to populate Daily Revenue on dashboard)
                    cmd.CommandText = $@"
                        INSERT INTO Invoices (AppointmentID, PatientID, ServiceName, Price, Discount, TotalAmount, Amount, PaymentMethod, IsPaid, CreatedAt, InvoiceDate)
                        VALUES (1, 1, 'Cardiology Consultation', 350.00, 0.00, 350.00, 350.00, 'Cash', 1, '{todayStr}', '{todayStr}'),
                               (3, 3, 'Dermatology Consultation', 300.00, 50.00, 250.00, 250.00, 'Card', 1, '{todayStr}', '{todayStr}');";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $@"
                        INSERT INTO Payments (InvoiceID, AmountPaid, PaymentDate, PaymentMethod)
                        VALUES (1, 350.00, '{todayStr}', 'Cash'),
                               (2, 250.00, '{todayStr}', 'Card');";
                    cmd.ExecuteNonQuery();

                    // 9. Seed Inventory
                    cmd.CommandText = @"
                        INSERT INTO Inventory (DrugName, ItemName, Category, Quantity, ExpiryDate, MinAlertQty, AlertLevel)
                        VALUES ('Paracetamol 500mg', 'Paracetamol 500mg', 'أدوية وعقاقير', 180, '2027-12-31', 20, 20),
                               ('Amoxicillin 500mg', 'Amoxicillin 500mg', 'أدوية وعقاقير', 8, '2026-09-15', 15, 15),
                               ('Concor 5mg', 'Concor 5mg', 'أدوية وعقاقير', 55, '2028-03-22', 10, 10),
                               ('Aspirin 81mg', 'Aspirin 81mg', 'أدوية وعقاقير', 200, '2027-05-18', 30, 30),
                               ('Ventolin Inhaler', 'Ventolin Inhaler', 'أدوية وعقاقير', 4, '2026-11-10', 5, 5);";
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
        }

        // Standard helpers for running queries safely and efficiently
        public static DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
