#include <stdio.h>

int somaLista(int lista[], int tamanho) {
    //verifica se está vazia
    if (tamanho == 0) {
        return 0;
    }

    else {
        return lista[tamanho - 1] + somaLista(lista, tamanho - 1);
    }
}

int main() {
    int lista[] = {1, 2, 3, 4, 5, 6};
    int n = sizeof(lista) / sizeof(lista[0]); //calcula numero de elementos da lista

    printf("Lista: ")
    for (int i = 0; i < n; i++) {
        printf("%d", lista[i]); //printa a lista
    }
    int resultado = somaLista(lista, n); //chama a função
    printf("A soma dos elementos da lista é: %d\n", resultado); //exibi o resultado

    return 0;
}