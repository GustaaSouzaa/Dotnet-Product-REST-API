import React, { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [produtos, setProdutos] = useState([]);
  const [novoProduto, setNovoProduto] = useState({ nome: '', preco: '', categoria: '' });

  // URL da nossa API
  const apiUrl = 'https://localhost:7194/api/Produto';

  // Função para buscar os produtos
  const fetchProdutos = async () => {
    try {
      const response = await axios.get(apiUrl);
      setProdutos(response.data);
    } catch (error) {
      console.error('Erro ao buscar produtos:', error);
    }
  };

  // Função para lidar com o envio do formulário
  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await axios.post(apiUrl, novoProduto);
      setNovoProduto({ nome: '', preco: '', categoria: '' });
      fetchProdutos(); // Atualiza a lista após o cadastro
    } catch (error) {
      console.error('Erro ao cadastrar produto:', error);
    }
  };

  // Função para lidar com a mudança dos inputs
  const handleChange = (e) => {
    const { name, value } = e.target;
    setNovoProduto(prevState => ({
      ...prevState,
      [name]: value
    }));
  };

  // useEffect para buscar os produtos ao carregar a página
  useEffect(() => {
    fetchProdutos();
  }, []);

  return (
    <div style={{ padding: '20px' }}>
      <h1>Cadastro de Produtos</h1>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          name="nome"
          placeholder="Nome"
          value={novoProduto.nome}
          onChange={handleChange}
        />
        <input
          type="number"
          name="preco"
          placeholder="Preço"
          value={novoProduto.preco}
          onChange={handleChange}
        />
        <input
          type="text"
          name="categoria"
          placeholder="Categoria"
          value={novoProduto.categoria}
          onChange={handleChange}
        />
        <button type="submit">Cadastrar</button>
      </form>

      <hr style={{ margin: '20px 0' }} />

      <h2>Lista de Produtos</h2>
      <ul>
        {produtos.map(produto => (
          <li key={produto.id}>
            <strong>{produto.nome}</strong> - R${produto.preco} ({produto.categoria})
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;