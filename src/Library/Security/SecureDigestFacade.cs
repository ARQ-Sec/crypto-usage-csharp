using System.Security.Cryptography; namespace Arq.Lab.Library.Security; public static class SecureDigestFacade { public static byte[] Sha256(byte[] value) => SHA256.HashData(value); }
