Imports System.Security.Cryptography
Imports System.Text
Public Class CEncryption
    Dim DES As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim SHA1 As New SHA1CryptoServiceProvider
    Function MD5Hash(value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Function EncryptData(ByVal encryptedtext As String, ByVal key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(encryptedtext)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    Function DecryptData(ByVal encryptedtext As String, ByVal key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim buffer As Byte() = Convert.FromBase64String(encryptedtext)

        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
End Class
