#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#define MAX_SIZE 100 // Define a capacidade máxima para pilha e fila.

// --- Definição e Funções da Pilha (LIFO) ---
typedef struct
{
    char itens[MAX_SIZE];
    int topo;
} PilhaChar;

void inicializarPilhaChar(PilhaChar *p)
{
    p->topo = -1; // Indica pilha vazia.
}

int estaVaziaPilhaChar(PilhaChar *p)
{
    return (p->topo == -1);
}

int estaCheiaPilhaChar(PilhaChar *p)
{
    return (p->topo == MAX_SIZE - 1);
}

void pushChar(PilhaChar *p, char caractere)
{
    if (estaCheiaPilhaChar(p)) return;
    p->topo++;
    p->itens[p->topo] = caractere;
}

char popChar(PilhaChar *p)
{
    if (estaVaziaPilhaChar(p)) return '\0'; // Retorna nulo se vazia.
    char caractere = p->itens[p->topo];
    p->topo--;
    return caractere;
}

// --- Definição e Funções da Fila (FIFO) ---
typedef struct
{
    char itens[MAX_SIZE];
    int frente;
    int tras;
    int contador;
} FilaChar;

void inicializarFilaChar(FilaChar *f)
{
    f->frente = 0;
    f->tras = -1;
    f->contador = 0; // Indica fila vazia.
}

int estaVaziaFilaChar(FilaChar *f)
{
    return (f->contador == 0);
}

int estaCheiaFilaChar(FilaChar *f)
{
    return (f->contador == MAX_SIZE);
}

void enqueueChar(FilaChar *f, char caractere)
{
    if (estaCheiaFilaChar(f)) return;
    f->tras = (f->tras + 1) % MAX_SIZE; // Movimento circular.
    f->itens[f->tras] = caractere;
    f->contador++;
}

char dequeueChar(FilaChar *f)
{
    if (estaVaziaFilaChar(f)) return '\0'; // Retorna nulo se vazia.
    char caractere = f->itens[f->frente];
    f->frente = (f->frente + 1) % MAX_SIZE; // Movimento circular.
    f->contador--;
    return caractere;
}

---

## Verificação de Palíndromo

Esta função determina se uma string é um **palíndromo**, ignorando maiúsculas/minúsculas e caracteres não alfanuméricos.

```c
int verifica_palindromo(const char *palavra)
{
    PilhaChar pilha;
    FilaChar fila;

    inicializarPilhaChar(&pilha);
    inicializarFilaChar(&fila);

    int i = 0;
    while (palavra[i] != '\0')
    {
        char caractere_min = tolower(palavra[i]);

        // Adiciona apenas caracteres alfanuméricos às estruturas.
        if (isalnum(caractere_min))
        {
            // Aborta se a palavra for muito longa para as estruturas.
            if (estaCheiaPilhaChar(&pilha) || estaCheiaFilaChar(&fila))
            {
                printf("Erro: A palavra '%s' excede o tamanho maximo permitido (%d).\n", palavra, MAX_SIZE);
                return 0;
            }

            pushChar(&pilha, caractere_min);
            enqueueChar(&fila, caractere_min);
        }
        i++;
    }

    // Compara caracteres retirados da pilha (inverso) e da fila (normal).
    while (!estaVaziaPilhaChar(&pilha))
    {
        char char_pilha = popChar(&pilha);
        char char_fila = dequeueChar(&fila);

        if (char_pilha != char_fila)
        {
            return 0; // Não é palíndromo se houver diferença.
        }
    }

    return 1; // É um palíndromo.
}

---

## Função Principal

Demonstra a verificação de palíndromos com uma lista de palavras de exemplo.

```c
int main(void)
{
    printf("--- Verificacao de Palindromo com Pilha e Fila ---\n\n");

    const char *palavras[] = {
        "arara",
        "ovo",
        "Madame",
        "A base do teto desaba",
        "Socorram me subi no onibus em Marrocos",
        "Hello World",
        "12321",
        "Teste",
        "a",
        "Abcba"
    };

    int num_palavras = sizeof(palavras) / sizeof(palavras[0]);

    for (int i = 0; i < num_palavras; i++)
    {
        printf("Palavra: \"%s\" -> Eh palindromo? %s\n",
               palavras[i],
               verifica_palindromo(palavras[i]) ? "Sim" : "Nao");
    }

    return 0;
}