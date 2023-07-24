// Factory cho SinhVienLopHoc
public class SinhVienLopHocFactory : ISinhVienFactory
{
    public SinhVien CreateSinhVien()
    {
        return new SinhVienLopHoc();
    }
}

// Factory cho SinhVienTruongHoc
public class SinhVienTruongHocFactory : ISinhVienFactory
{
    public SinhVien CreateSinhVien()
    {
        return new SinhVienTruongHoc();
    }
}
