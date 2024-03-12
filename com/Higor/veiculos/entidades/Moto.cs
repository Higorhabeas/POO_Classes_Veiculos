using com.Higor.veiculos.entidades.veiculo;

class Moto : Veiculo
{
    private string descanso;
    private bool mataCachorro;

    public Moto(string _placa,string _renavan,string _descanoso, bool _mataCachorro) : base(_placa, _renavan)
    {
        this.descanso = _descanoso;
        this.mataCachorro = _mataCachorro;
    }

    public void setDescanso(string _descanoso) {
        this.descanso = _descanoso;
    }

    public string getDescanso(){
        return this.descanso;
    }
}