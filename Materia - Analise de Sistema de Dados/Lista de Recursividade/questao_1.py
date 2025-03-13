# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 01 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

def fatorial(numero):
    if numero <= 1:
        return 1
    return numero * fatorial(numero - 1)

print(fatorial(5))
