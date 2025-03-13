# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 02 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

def soma_de_lista(lista):
    if len(lista) == 0:
        return 0
    return lista[0] + soma_de_lista(lista[1:])

lista = [1,2,3,4]
print(soma_de_lista(lista))
