using LivrariaCactus_Balao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LivrariaCactus_Balao.AcessoDados {
    public class LivrosInit :CreateDatabaseIfNotExists<LivroContexto>{
        protected override void Seed(LivroContexto contexto) {
            List<Genero> generos = new List<Genero>()
            {
                new Genero() { Nome = "Administração" },
                new Genero() { Nome = "Agropecuária" },
                new Genero() { Nome = "Artes" },
                new Genero() { Nome = "Autoajuda" },
                new Genero() { Nome = "Ciências Biológicas" },
                new Genero() { Nome = "Ciências Exatas" },
                new Genero() { Nome = "Ciências Humanas e Sociais" },
                new Genero() { Nome = "Cursos e Idiomas" },
                new Genero() { Nome = "Didáticos" },
                new Genero() { Nome = "Direito" },
                new Genero() { Nome = "Economia" },
                new Genero() { Nome = "Engenharia e Tecnologia" },
                new Genero() { Nome = "Gastronomia" },
                new Genero() { Nome = "Geografia e Historia" },
                new Genero() { Nome = "Informática" },
                new Genero() { Nome = "Linguística" },
                new Genero() { Nome = "Literatura Nacional" },
                new Genero() { Nome = "Medicina" },
                new Genero() { Nome = "Religião" },
                new Genero() { Nome = "Turismo" }
            };

            generos.ForEach(g => contexto.Generos.Add(g));

            List<Livro> livros = new List<Livro>()
            {
                new Livro() {
                            Titulo = "O Poder do Hábito - Por Que Fazemos o Que Fazemos na Vida e Nos Negócios",
                            Autor = "Duhigg, Charles",
                            AnoEdicao = 2012,
                            Valor = 40.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Os Segredos da Mente Milionária - Aprenda a Enriquecer Mudando seus Conceitos Sobre o Dinheiro",
                            Autor = "Eker, T. Harv",
                            AnoEdicao = 1992,
                            Valor = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Administração"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Adestramento Inteligente",
                            Autor = "Rossi, Alexandre",
                            AnoEdicao = 2015,
                            Valor = 20.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Aves Florestais do Brasil",
                            Autor = "Bini, Etson",
                            AnoEdicao = 2014,
                            Valor = 89.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Agropecuária"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Guerra Civil",
                            Autor = "McNiven, Steve; MILLAR, MARK",
                            AnoEdicao = 2010,
                            Valor = 48m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Batman - A Morte da Família",
                            Autor = "Capullo, Greg; Snyder, Scott",
                            AnoEdicao = 2016,
                            Valor = 60.80m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Artes"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Manual de Sobrevivência do Adolescente",
                            Autor = "Loures, Camila",
                            AnoEdicao = 2016,
                            Valor = 19.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "O Mapa da Felicidade - As Coordenadas Para Curar A Sua Vida e Nunca Mais Olhar Para Trás",
                            Autor = "Capelas, Heloísa",
                            AnoEdicao = 2014,
                            Valor = 23.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Autoajuda"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "A Origem Das Espécies - Edição Ilustrada",
                            Autor = "Darwin, Charles",
                            AnoEdicao = 2014,
                            Valor = 71.90m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "A Sexta Extinção - Uma História Não Natural",
                            Autor = "Kolbert, Elizabeth",
                            AnoEdicao = 2015,
                            Valor = 17.00m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Biológicas"),
                            Alugado = "n"
                },
                new Livro() {
                            Titulo = "Raciocínio Lógico Facilitado",
                            Autor = "Villar, Bruno",
                            AnoEdicao = 2016,
                            Valor = 134.10m,
                            Genero = generos.FirstOrDefault(g => g.Nome == "Ciências Exatas"),
                            Alugado = "n"
                }
 
            };

            livros.ForEach(l => contexto.Livros.Add(l));

            contexto.SaveChanges();
        }
    }
}