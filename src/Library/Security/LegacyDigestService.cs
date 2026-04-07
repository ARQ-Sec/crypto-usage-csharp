using System.Security.Cryptography; namespace Arq.Lab.Library.Security; public static class LegacyDigestService { public static byte[] Md5(byte[] value) => MD5.Create().ComputeHash(value); }
