# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 04 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
import sys

sys.setrecursionlimit(2000)

cotacao_dolar = [4.93, 4.87, 4.97, 4.99, 5.17, 5.14, 5.36, 5.45, 5.46, 5.57, 5.63, 5.78]
rendimento = 0.05
investimento_reais = 500
meta100k = 100000
meta1m = 1000000

def poupanca(dolares_na_conta=0, mes=0, marco=meta100k):
    cotacao_atual = cotacao_dolar[mes % 12]
    investimento_dolares = investimento_reais / cotacao_atual
    dolares_na_conta *= (1 + rendimento)
    dolares_na_conta += investimento_dolares
    reais_na_conta = dolares_na_conta * cotacao_atual
    mes += 1
    
    if reais_na_conta >= marco:
        anos = mes // 12
        meses_restantes = mes % 12
        valor_total = investimento_reais * mes
        juros_acumulados = reais_na_conta - valor_total

        print(".__________________________________________________.")
        print(f"""
◦= O valor total investido foi de: R$ {valor_total:.2f}
◦= Juros totais até os {marco} foram de: R$ {juros_acumulados:.2f}
◦= Tempo gasto: {anos} anos e {meses_restantes} meses
""")
        print(".==================================================.")
        return reais_na_conta
    
    return poupanca(dolares_na_conta, mes, marco)

print("\nResultado de R$100k:")
poupanca(marco=meta100k)

print("\nResultado de R$1M:")
poupanca(marco=meta1m)