Siswa siswaObj = new Siswa("Fahri", "Fahridm@gmail.com", "1115", "Pelajar/Siswa", "X PG 1");
Guru guruObj = new Guru("Fahra", "Fahramd@gmail.com", "5111", "Pengajar/Guru", "Bahasa india");

siswaObj.TampilkanInfo();
siswaObj.SubmitTugas();
Console.WriteLine();
guruObj.TampilkanInfo();
guruObj.NilaiTugas();

public class user
{
    public string nama;
    public string email;
    public string password;
    public string role;

    public user (string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }
    public void TampilkanInfo()
    {
        Console.WriteLine($"Name: {nama} | Role: {role} ");
    }
    
}

class Siswa : user
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string className) : base(nama, email, password, role)
    {
        ClassName = className;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"{nama} dari kelas {ClassName} sudah mengumpulkan tugas!");
    }
}

class Guru : user
{
    public string Mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {nama} telah menilai semua tugas mapel {Mapel}.");
    }
}