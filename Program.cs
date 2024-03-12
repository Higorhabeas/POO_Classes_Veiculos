// See https://aka.ms/new-console-template for more information


    // Teste de Carro
        Carro carro1 = new Carro("HNY-0101", "123456",4,"3 Pontos");
        carro1.mostrar();

         Carro carro2 = new Carro("HLL-0102", "654321",2,"3 Pontos");
        carro2.mostrar();
    

     // Teste de Sedan
        Sedan sedan1 = new Sedan("GKY-2323", "123333", 4, "3 Pontos",30.50);
        sedan1.mostrar();

        Sedan sedan2 = new Sedan("GKU-2324", "123222", 4, "3 Pontos",25.50);
        sedan2.mostrar();

     // Teste de Seguro
        Seguro seguroCarro = new SeguroCarro();
        seguroCarro.seguroParticular();