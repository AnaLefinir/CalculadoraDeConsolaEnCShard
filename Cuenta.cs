using System;
using System.Collections.Generic;

public class Cuenta
{
    public int numeroDeCuenta{ get; set; }
    public List<Titular> Titulares= new List <Titular>();
    public int saldoCuenta{ get; set;}
}