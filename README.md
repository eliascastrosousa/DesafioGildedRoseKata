## DesafioGildedRoseKata

### Sobre o processo de Reestruturação do programa.

Antes de tudo, começamos lendo as especificações de requisitos, ou seja, entendendo o problema apresentado e as regras de negócio. 

Entendendo suas particularidades, começamos então a ler o código e ver como ele se comportava em execução, e então sentimos a necessidade de limpar a visualização do código. Por isso, optamos em alterar para português algumas informações e mudarmos o visual de saída do programa.

Feito isso, começamos então as alterações da classe GildedRose, nela é onde estão os adicionamentos e decrementos dos itens. Começamos destrinchando cada um dos itens, como o Queijo Brie envelhecido, as sulfuras e o item conjurado. Optamos por limpar o código utilizando métodos específicos para cada um dos itens, pois cada um deles tem um comportamento próprio. Depois disso criamos um switch e cases para cada item, neles chamando os métodos que farão os updates necessários.

Por fim, fizemos o adicionamento do último método, o método “Conjured” junto com suas particularidades.

Com essa nova repaginada no código, pode ser adicionado N novos itens de forma simples, pois é só adicionar mais um Case no Switch e o método específico desse novo item, que está feita a melhoria do sistema.
