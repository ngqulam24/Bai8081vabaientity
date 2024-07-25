using System;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("BÀI TẬP 80 81 VÀ BÀI ENTITY");
        Console.WriteLine("------------------------");
        int choice;
        do
        {
            Console.WriteLine("\nBài tập 80:");
            Console.Write("a. Viết 1 hàm static ff của C# console project thực hiện:\r\n1 vòng lặp vô hạn trong thân vòng lặp:\r\ncó 1 lệnh tạo 1 số nguyên ngẫu nhiên n, nếu n chia hết cho 2025 thì dừng lại, trái lại hiển thị n, delay 100ms.\r\nb. Đặt ff để thực thi trong 1 luồng, khi kết thúc luồng thì hiển thị \"Đã thực hiện xong\"\n");
            Console.WriteLine("\nBài tập 81. Phân biệt lệnh Thread.Sleep(100); của gói using System.Threading và lệnh Task.Delay(100); của gói using System.Threading.Tasks\n");
            Console.WriteLine("Bài tập entity.");
            Console.Write("\nNhập lựa chọn của bạn (80, 81, 999999, hoặc 0 để thoát): ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 80:
                    Bai80();
                    break;
                case 81:
                    Bai81();
                    break;
                case 999999:
                    BaiEntity();
                    break;
                case 0:
                    Console.WriteLine("Exited......");
                    break;
                default:
                    Console.WriteLine("Nhập sai lựa chọn!");
                    break;
            }
        } while (choice != 0);
    }
    static void Bai80()
    {
        // Khởi tạo và chạy luồng mới
        Task.Run(() => ff());

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }
    static void ff()
    {
        while (true)
        {
            // Tạo số ngẫu nhiên
            int n = new Random().Next();

            // Nếu n chia hết cho 2025 thì thoát vòng lặp
            if (n % 2025 == 0)
            {
                break;
            }
            else
            {
                // Hiển thị n và delay 100ms
                Console.WriteLine(n);
                Thread.Sleep(100);
            }
        }
    }
    static void Bai81() 
    {
        Console.WriteLine("\nThread.Sleep(100):\r\nThuộc về namespace System.Threading.\r\nDùng để tạm dừng luồng hiện tại trong một khoảng thời gian cụ thể (tính bằng mili giây).\r\nKhi gọi Thread.Sleep(100), luồng hiện tại sẽ bị chặn và không thực hiện bất kỳ công việc nào trong khoảng thời gian đó.\r\nViệc sử dụng quá nhiều Thread.Sleep() có thể dẫn đến hiệu suất kém của ứng dụng, vì nó làm tăng thời gian chờ đợi và hạn chế khả năng tận dụng tài nguyên máy tính.\r\nTask.Delay(100):\r\nThuộc về namespace System.Threading.Tasks.\r\nDùng để tạo một Task mới, trong đó sẽ tạm dừng thực thi trong một khoảng thời gian cụ thể (tính bằng mili giây).\r\nKhi gọi Task.Delay(100), nó sẽ trả về một Task mà bạn có thể sử dụng để tiếp tục thực hiện các công việc khác trong khi đợi.\r\nViệc sử dụng Task.Delay() thường tốt hơn Thread.Sleep() vì nó không chặn luồng hiện tại, thay vào đó nó tạo một luồng mới để thực hiện việc đợi, do đó không làm ảnh hưởng đến hiệu suất của ứng dụng.");
    }
    static void BaiEntity()
    {
        Console.WriteLine("\nNothing lewlew =))");
    }
}