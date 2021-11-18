using System;
using System.Collections.Generic;

namespace Quanlynhansu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nhanvien> DSDV = new List<Nhanvien>();
            List<Khachhang> DBDV = new List<Khachhang>();
            while (true)
            {
                Menu();
                Console.WriteLine("lua chon: ");
                string KT = Console.ReadLine();
                if (KT == "ae") {
                    ThemNhanvien(DSDV);
                }
                else if (KT == "ac")
                {
                    Themkhachhang(DBDV);
                }
                else if (KT == "dae")
                {
                    TTNV(DSDV);
                }
                else if (KT == "dac")
                {
                    TTKH(DBDV);
                }
                else if (KT == "cs")
                {
                    TKKH(DBDV);
                }
            }
        }

        static void ThemNhanvien(List<Nhanvien> DSDV)
        {
            Console.Write("Ten:");
            string KI = Console.ReadLine();
            Console.Write("Ma:");
            string KO = Console.ReadLine();
            Console.Write("Gioitinh:");
            string KP = Console.ReadLine();
            Console.Write("Ngaysinh:");
            string Kl = Console.ReadLine();
            Console.Write("Bangcap:");
            string KM = Console.ReadLine();
            Nhanvien NV = new Nhanvien(KO, KI, KP, Kl, KM);
            DSDV.Add(NV);

        }
        static void Themkhachhang(List<Khachhang> DBDV)

        {
            Console.Write("Ten:");
            string KI = Console.ReadLine();
            Console.Write("Ma:");
            string KO = Console.ReadLine();
            Console.Write("Gioitinh:");
            string KP = Console.ReadLine();
            Console.Write("Ngaysinh:");
            string Kl = Console.ReadLine();
            Console.Write("Loaikhachhang:");
            string KM = Console.ReadLine();
            Khachhang NV = new Khachhang(KO, KI, KP, Kl, KM);
            DBDV.Add(NV);
        }
        static void TTNV(List<Nhanvien> DSDV)
        {
            for (int i = 0; i < DSDV.Count ; i++)
            {
                DSDV[i].infor();

            }
        } 
        static void TTKH ( List<Khachhang> DBDV)
        {
            for (int i = 0; i < DBDV.Count ; i++)
            {
                DBDV[i].infor();

            }
        }
        static void TKKH(List<Khachhang> DBDV)
        {
            int Khachhangmoi = 0;
            int Thanhvien = 0;
            int vip = 0;
            for (int i = 0; i < DBDV.Count ; i++)
            {
               if (DBDV[i].LoaiKH == "Khachhangmoi")
                {
                    Khachhangmoi += 1;
                }
               else if (DBDV[i].LoaiKH == "Thanhvien")
                {
                    Thanhvien += 1;
                }
               else if (DBDV[i].LoaiKH == "vip")
                {
                    vip += 1;
                }

            }
            Console.WriteLine("so Khach hang moi:{0}", Khachhangmoi);
            Console.WriteLine(" so thanh vien:{0}", Thanhvien);
            Console.WriteLine(" so thanh vien vip:{0}", vip);
        } 
        static void Menu()
        {
            Console.WriteLine("Them nhan vien ae");
            Console.WriteLine("Them khach hang ac ");
            Console.WriteLine("hien thi thong tin nhan vien dae ");
            Console.WriteLine("hien thi thong tin khach hang dac ");
            Console.WriteLine("thong ke khach hang cs ");
        }
    }
    
}
