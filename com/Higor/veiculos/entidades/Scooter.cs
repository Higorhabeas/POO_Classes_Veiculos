class Scooter : Moto
{
    private string compartimentoInterno;

    public void setCompartimentoInterno(string _campartimentoInterno){

        this.compartimentoInterno = _campartimentoInterno;
    }

    public string getCompartimentoInterno(){

        return this.compartimentoInterno;
    }

    public Scooter(string _placa,string _renavan,string _descanoso,bool _mataCachorro,string _compartimentoInterno) : base(_placa,_renavan,_descanoso,_mataCachorro){
        
        this.compartimentoInterno = _compartimentoInterno;
    }
}