class Motocros : Moto
{
    private bool competicao;

    public void setCompeticao(bool _competicao){

        this.competicao = _competicao;
    }

    public bool getCompeticao(){

        return this.competicao;
    }

    public Motocros (string _placa, string _renavan, string _descanoso,bool _mataCachorro, bool _competicao) : base(_placa,_renavan,_descanoso,_mataCachorro){
        
        this.competicao = _competicao;
    }
}