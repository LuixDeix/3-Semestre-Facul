#include <stdio.h>
#include <string.h>

void inverter(char *str, int inicio, int fim) {
    char temp; //variavel temporaria para troca de caracteres

    //verifica se tá ok
    if (inicio >= fim) {
        return;
    }

    //realiza a troca
    temp = str[incio];
    str[inicio] = str[fim];
    str[fim] = temp;
    
    inverter(str, inicio + 1, fim - 1);
}

int main() {
    char textinho[] = "socorramesubinoonibusemmarrocos";
    int tamanho = strlen(textinho);

    printf("Texto: %s", textinho);

    inverter(textinho, 0, tamanho - 1);

    printf("String invertida: %s\n", textinho);

    return 0;
}