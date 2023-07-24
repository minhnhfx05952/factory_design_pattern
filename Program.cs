class Program
{
    static void Main(string[] args)
    {
        // Sử dụng Factory cho SinhVienLopHoc
        ISinhVienFactory factory1 = new SinhVienLopHocFactory();
        SinhVien sinhVienLopHoc = factory1.CreateSinhVien();
        sinhVienLopHoc.ThongTin();

        // Sử dụng Factory cho SinhVienTruongHoc
        ISinhVienFactory factory2 = new SinhVienTruongHocFactory();
        SinhVien sinhVienTruongHoc = factory2.CreateSinhVien();
        sinhVienTruongHoc.ThongTin();
    }
}
