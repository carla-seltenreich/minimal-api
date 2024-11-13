using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    public class VeiculoTest
    {
        [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo
        {
            Id = 1,
            Nome = "T-Cross",
            Marca = "Volkswagen",
            Ano = 2024
        };

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Palio", veiculo.Nome);
        Assert.AreEqual("Fiat", veiculo.Marca);
        Assert.AreEqual(2015, veiculo.Ano);

        Assert.AreNotEqual(2, veiculo.Id);
        Assert.AreNotEqual("Nivus", veiculo.Nome);
        Assert.AreNotEqual("Volkswagen", veiculo.Marca);
        Assert.AreNotEqual(2024, veiculo.Ano);
    }
    }
}