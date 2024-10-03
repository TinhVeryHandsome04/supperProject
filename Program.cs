
using System.Reflection.Metadata.Ecma335;
using System;
namespace Program;
class HinhChuNhat{
    private double length;      //field
    private double  width;      //field
    public HinhChuNhat(){           //Constructor
        this.length = 0;
        this.width = 0;     
    }
    public void input(){        //Method
        Console.Write("Nhap chieu dai: ");
        this.Length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        this.width = Convert.ToDouble(Console.ReadLine());
    }
    public void output(){           //Method
        Console.WriteLine("Length: " + this.length);
        Console.WriteLine("Width: " + width);
    }
    public double chuVi(){          //Method
        double V = (this.length + this.width) * 2L;
        return V;
    }
    public double DienTich(){    //Method   
        double S = this.length * this.width;
        return S;
    }
    public double Length{           //Property
        get { return this.length;}
        set {
            if(value >= this.length && value >= this.width)
                this.length = value; 
            else
                Console.WriteLine("Chieu dai khong hop le !");
            }
    }
    public double Weight{           //Property
        get { return this.width;}
        set {
            do{
            if(value >= 0 && value <= this.length)
                this.width = value; 
            else 
                Console.WriteLine("CHieu rong ko hop le !");
            }while(value <= 0 && value >= this.length);
        }
    }

    //Method
    static void Main(string []agrs){                
        HinhChuNhat hcn = new HinhChuNhat();
        HinhChuNhat hcn2 = new HinhChuNhat();
        hcn.input();
        Console.WriteLine("Chi vi: " + hcn.chuVi());
        Console.WriteLine("Dien Tich: " + hcn.DienTich());

        //hcn2.input();
        hcn2.output();
        Console.ReadLine();
    }
}