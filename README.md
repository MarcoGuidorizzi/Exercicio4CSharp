[README_ex04.md](https://github.com/user-attachments/files/26547413/README_ex04.md)
# ⏱️ Exercício 04 — Conversor de Segundos para Horas:Minutos:Segundos

Programa de estrutura sequencial que lê um valor inteiro representando a duração de um evento em segundos e o converte para o formato **horas:minutos:segundos**.

---

## 🧠 Conceitos Aplicados

- Estrutura sequencial
- Operadores aritméticos: divisão inteira `/` e módulo `%`
- Tipo `int`
- Formatação de saída com `Console.WriteLine`

---

## 📥 Entrada

| Variável | Tipo  | Descrição                        |
|----------|-------|----------------------------------|
| `N`      | `int` | Duração do evento em segundos    |

## 📤 Saída

Tempo convertido no formato `horas:minutos:segundos`:

| Variável | Fórmula              |
|----------|----------------------|
| `horas`  | `N / 3600`           |
| `resto` (minutos) | `(N % 3600) / 60` |
| segundos | `N % 60`             |

---

## 💡 Exemplos

| Entrada  | Saída      |
|----------|------------|
| `556`    | `0:9:16`   |
| `1`      | `0:0:1`    |
| `140153` | `38:55:53` |

---

## 🛠️ Tecnologias

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)

- **Linguagem:** C#
- **Plataforma:** .NET 10
- **Versionamento:** Git

---

## ▶️ Como Executar

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/seu-repositorio.git

# Acesse a pasta do exercício
cd Exercicio04

# Execute o projeto
dotnet run
```

---

## 📁 Estrutura do Projeto

```
Exercicio04/
├── Program.cs
├── Exercicio04.csproj
└── README.md
```
