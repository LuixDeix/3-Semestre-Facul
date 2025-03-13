# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 06 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
import sys

sys.setrecursionlimit(2000)

def juros_compostos_acoes(saldo, meses, investido, investimento_mensal, div_mensal, marco, marco_atingido=None):
    if saldo >= marco:
        anos = meses // 12
        meses_restantes = meses % 12
        dividendos = saldo - investido
        
        print(".__________________________________________________.")
        print(f"""
◦= O valor total investido foi de: R$ {investido:.2f}
◦= Dividendos totais até os R${marco}: R$ {dividendos:.2f}
◦= Tempo gasto: {anos} anos e {meses_restantes} meses
""")
        print(".==================================================.")
        return saldo
    
    novo_saldo = saldo + investimento_mensal
    novo_investido = investido + investimento_mensal
    dividendos = novo_saldo * div_mensal
    novo_saldo += dividendos
    
    return juros_compostos_acoes(novo_saldo, meses + 1, novo_investido, investimento_mensal, div_mensal, marco, marco_atingido)

investimento_mensal = 80
saldo = 0
meses = 0
investido = 0

div_marfrig = 0.2983
div_petrobras = 0.1349
div_itausa = 0.10
div_medio = (div_petrobras + div_marfrig + div_itausa) / 3
div_mensal = div_medio / 12

marco_100k = 100000
marco_1M = 1000000

print(".==================================================.")

print("\nResultado para R$100k:")
juros_compostos_acoes(saldo, meses, investido, investimento_mensal, div_mensal, marco_100k)

print("\nResultado para R$1M:")
juros_compostos_acoes(saldo, meses, investido, investimento_mensal, div_mensal, marco_1M)
