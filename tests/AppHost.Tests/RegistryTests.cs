using Arq.Lab.Library.Partners; using Xunit; public class RegistryTests { [Fact] public void LoadsSeed() { Assert.NotEmpty(PartnersRegistry.Load()); } }
