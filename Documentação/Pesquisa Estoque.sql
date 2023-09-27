SELECT 
		pe.*,
        p.nome,
        t.sigla,
        pe.QtdeEstoque,
        COALESCE(pe.Preco, p.Preco, 0) as Preco        
  FROM produtoestoque pe 
 INNER JOIN produto p ON pe.ProdutoId = p.Id
 INNER JOIN tamanho t ON pe.TamanhoId = t.Id