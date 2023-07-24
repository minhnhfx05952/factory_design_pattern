// Giao diện chung cho SinhVien
public interface SinhVien
{
    void ThongTin();
}

// SinhVienLopHoc
public class SinhVienLopHoc : SinhVien
{
    public void ThongTin()
    {
        Console.WriteLine("Đây là sinh viên trong lớp học.");
    }
}

// SinhVienTruongHoc
public class SinhVienTruongHoc : SinhVien
{
    public void ThongTin()
    {
        Console.WriteLine("Đây là sinh viên trong trường học.");
    }
}
