class Picape : Carro
{
    private double volumeCacamba;

    public void setVolumeCacamba(double _volumeCacamba){
        this.volumeCacamba = _volumeCacamba;
    }

    public double getVolumeCacamba(){
        return this.volumeCacamba;
    }

    public Picape(string _placa, string _renavan,int _numPortas,string _cinto,double _volumeCacamba) : base ( _placa,_renavan, _numPortas,_cinto){
        this.volumeCacamba = _volumeCacamba;
    }

    public override void mostrar()
    {
        base.mostrar();
        Console.WriteLine($"O volume total da caçamba é: {volumeCacamba}");
    }


}