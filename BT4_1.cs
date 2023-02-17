using System;

namespace BT4
{
    // Khởi tạo lớp Student có các thuộc tính và 2 phương thức: CalculateAverageScore và PrintInfo
    class Student
    {
        // Định nghĩa các thuộc tính kèm phương thức truy cập
        public string ID { get; set; }
        public string Name { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double AverageScore { get; set; }

        // Phương thức CalculateAverageScore
        public void CalculateAverageScore()
        {
            AverageScore = (MathScore + PhysicsScore + ChemistryScore) / 3;
        }

        // Phương thức PrintInfo
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("\tID: {0}", ID);
            Console.WriteLine("\tName: {0}", Name);
            Console.WriteLine("\tMath Score: {0}", MathScore);
            Console.WriteLine("\tPhysics Score: {0}", PhysicsScore);
            Console.WriteLine("\tChemistry Score: {0}", ChemistryScore);
            Console.WriteLine("\tAverage Score: {0}", AverageScore);
        }
    };

    class BT4_1
    {
        // Hàm Main
        public static void Main(string[] args)
        {
            int n;
            // Khởi tạo mảng students có kiểu dl Student, tối đa 100 phần tử
            Student[] students = new Student[100];


            Console.WriteLine("Nhap So Hoc Sinh: ");
            n = int.Parse(Console.ReadLine());
            while (n <= 5 || n >= 50)
            {
                Console.WriteLine("Nhap Lai So Hoc Sinh (0 < n < 50): ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                // khởi tạo một đối tượng mới của lớp Student và lưu trữ đối tượng đó vào phần tử thứ i của mảng students.
                students[i] = new Student();

                Console.WriteLine("Enter information for student {0}:", i + 1);

                Console.Write("ID: ");
                students[i].ID = Console.ReadLine();
                while (students[i].ID.ToString().Length > 10)
                {
                    Console.Write("Re-Enter ID (khong qua 10 ky tu): ");
                    students[i].ID = Console.ReadLine();
                }

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();
                while (students[i].Name.ToString().Length > 30)
                {
                    Console.Write("Re-Enter Name (khong qua 30 ky tu): ");
                    students[i].Name = Console.ReadLine();
                }

                Console.Write("Math Score: ");
                students[i].MathScore = double.Parse(Console.ReadLine());
                while (students[i].MathScore < 0 || students[i].MathScore > 10)
                {
                    Console.Write("Re-Enter Math Score (0 <= Math Score <= 10): ");
                    students[i].MathScore = double.Parse(Console.ReadLine());
                }

                Console.Write("Physics Score: ");
                students[i].PhysicsScore = double.Parse(Console.ReadLine());
                while (students[i].PhysicsScore < 0 || students[i].PhysicsScore > 10)
                {
                    Console.Write("Re-Enter Physics Score (0 <= Physics Score <= 10): ");
                    students[i].PhysicsScore = double.Parse(Console.ReadLine());
                }

                Console.Write("Chemistry Score: ");
                students[i].ChemistryScore = double.Parse(Console.ReadLine());
                while (students[i].ChemistryScore < 0 || students[i].ChemistryScore > 10)
                {
                    Console.Write("Re-Enter Chemistry Score (0 <= Chemistry Score <= 10): ");
                    students[i].ChemistryScore = double.Parse(Console.ReadLine());
                }

                students[i].CalculateAverageScore();
            }

            // In toàn bộ thông tin của sinh viên - test-case: done
            Console.WriteLine("Thong tin vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    students[i].PrintInfo();
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    students[i].PrintInfo();
                    Console.ResetColor();
                }
            }

            // Tim sinh vien co diem trung binh cao nhat - test-case: done
            double maxAVG = 0;
            int j = 0;
            Console.WriteLine();
            Console.WriteLine("Sinh Vien co diem trung binh lon nhat la:");
            for (int i = 0; i < n; i++)
            {
                double currentMax = students[i].AverageScore;
                if (currentMax > maxAVG)
                {
                    maxAVG = currentMax;
                    j = i;
                }
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Red;
            students[j].PrintInfo();
            Console.ResetColor();


            // Tim sinh vien co diem trung binh thap nhat - test-case: done
            double minAVG = double.MaxValue;
            int k = 0;
            Console.WriteLine();
            Console.WriteLine("Sinh Vien co diem trung binh thap nhat la:");
            for (int i = 0; i < n; i++)
            {
                double currentMin = students[i].AverageScore;
                if (currentMin < minAVG)
                {
                    minAVG = currentMin;
                    k = i;
                }
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            students[k].PrintInfo();
            Console.ResetColor();

            // Hien thi diem tbc cua ca lop: test-case: done
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += students[i].AverageScore;
            }
            sum = sum / n;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Diem TBC cua ca lop la: {0}", sum);
            Console.ResetColor();


            // Hien thi danh sach Sv co diem tb < 5 - test-case:done
            Console.WriteLine();
            Console.WriteLine("Danh sach sinh vien co diem trung binh duoi 5 la:");
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (students[i].AverageScore < 5)
                {
                    if (i % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        students[i].PrintInfo();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        students[i].PrintInfo();
                        Console.ResetColor();
                    }
                }
                else
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Khong co !");
                Console.ResetColor();
            }

            // Ngăn việc đột ngột kết thúc chương trình
            Console.ReadLine();
        }
    }
}