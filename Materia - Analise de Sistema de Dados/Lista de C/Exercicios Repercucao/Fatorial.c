#include <stdio.h>

//long long para números grandões
long long int fatorial(int n){
    //fatorial de 0 é 1
    if (n == 0){
        return 1;
    }
    //Em outro caso, segue a fotoriação
    else if (n > 0) {
        return n * fatorial(n-1);
    }
    //Exceção no caso de negativo
    else {
        printf("Erro: Fatorial não pode ser feito em caso de negativos");
        return -1; //forma de indicar erro
    }
}

int main() {
    int numero;
    long long int resultado;
    printf("Digite um número: ");
    scanf("%d", &numero); //recebe um input de um número e o aplica a variavel numero
    
    retsultado = fatorial(numero);
    //verifica se não deu erro
    if (resultado != -1) {
        printf("O fatorial de %d é %lld", numero, resultado);
    }

    return 0;
}