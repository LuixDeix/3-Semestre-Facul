# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 04 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
import sys

sys.setrecursionlimit(2000)

def poupanca(saldo, meses, saldo_investido, taxa_juros, marco):
    if saldo >= marco:
        anos = meses // 12
        meses_restantes = meses % 12
        valor_total = saldo_investido * meses
        juros_acumulados = saldo - valor_total

        print(".__________________________________________________.")
        print(f"""
◦= O valor total investido foi de: R$ {valor_total:.2f}
◦= Juros totais até os {marco} foram de: R$ {juros_acumulados:.2f}
◦= Tempo gasto: {anos} anos e {meses_restantes} meses
""")
        print(".==================================================.")
        return saldo
    else:
        novo_saldo = saldo + saldo_investido
        juros = saldo * 0.0005
        novo_saldo = novo_saldo + juros
        return poupanca(novo_saldo, meses + 1, saldo_investido, taxa_juros, marco)

saldo_investido = 500
saldo_rendido = 0.0005

saldo = 0
meses = 0

atingiu_100k_de_Money = 100000
atingiu_1M_de_Money = 1000000

print("")
print("Resultado de R$100k:")
poupanca(saldo, meses, saldo_investido, saldo_rendido, atingiu_100k_de_Money)

print("\nResultado de R$1M:")
poupanca(saldo, meses, saldo_investido, saldo_rendido, atingiu_1M_de_Money)
