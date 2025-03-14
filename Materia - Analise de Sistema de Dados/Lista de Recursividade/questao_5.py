# Aluno: Luís Gabriel S. Alves
# RA: 209673
# -=-=- EXERCICIO 05 =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
import sys

sys.setrecursionlimit(20000)

def bitcoin(bitcoins_na_conta=0, mes=0, total_investido=0, metas_atingidas=None):
    if metas_atingidas is None:
        metas_atingidas = set()

    valor_bitcoin = 664484
    cotacao_bitcoin = [209410, 212335, 306600, 359693, 316517, 355299, 352500, 368540, 333842, 345411, 409131, 580819]
    investimento_reais = 250
    metas = {100000, 1000000, valor_bitcoin}
      
    cotacao_atual = cotacao_bitcoin[mes % 12]
    investimento_bitcoin = investimento_reais / cotacao_atual
    bitcoins_na_conta += investimento_bitcoin
    total_investido += investimento_reais
    mes += 1

    reais_na_conta = bitcoins_na_conta * cotacao_atual

    for meta in metas - metas_atingidas:
        if reais_na_conta >= meta:
            anos = mes // 12
            meses_restantes = mes % 12
            juros_acumulados = reais_na_conta - total_investido
            
            print(f"◦= Meta de R$ {meta:,.2f} atingida!")
            print(".__________________________________________________.")
            print(f"""
◦= Tempo gasto: {anos} anos e {meses_restantes} meses
◦= Valor total investido: R$ {total_investido:,.2f}
◦= Juros totais: R$ {juros_acumulados:,.2f}
""")
            print(".==================================================.")
            metas_atingidas.add(meta)  

    if metas_atingidas != metas:
        return bitcoin(bitcoins_na_conta, mes, total_investido, metas_atingidas)

print("")
print(".==================================================.")
bitcoin()
