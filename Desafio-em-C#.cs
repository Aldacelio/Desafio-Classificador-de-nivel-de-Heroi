using System;

class Program
{
    static void Main()
    {
        string nomeDoHeroi = "NomeDoHeroi";
        int xpDoHeroi = 5000;
        string nivelDoHeroi;

        if (xpDoHeroi < 1000) {
            nivelDoHeroi = "Ferro";
        } else if (xpDoHeroi <= 2000) {
            nivelDoHeroi = "Bronze";
        } else if (xpDoHeroi <= 5000) {
            nivelDoHeroi = "Prata";
        } else if (xpDoHeroi <= 7000) {
            nivelDoHeroi = "Ouro";
        } else if (xpDoHeroi <= 8000) {
            nivelDoHeroi = "Platina";
        } else if (xpDoHeroi <= 9000) {
            nivelDoHeroi = "Ascendente";
        } else if (xpDoHeroi <= 10000) {
            nivelDoHeroi = "Imortal";
        } else {
            nivelDoHeroi = "Radiante";
        }

        Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível de {nivelDoHeroi}");
    }
}
