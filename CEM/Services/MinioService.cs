using Minio;
using Minio.DataModel;
using Microsoft.Extensions.Configuration;
using Minio.DataModel.Args;

public class MinioService
{
    private readonly MinioClient _minioClient;
    private readonly string _bucketName;

    public MinioService(IConfiguration configuration)
    {
        var minioOptions = configuration.GetSection("Minio");
        _minioClient = (MinioClient)new MinioClient()
            .WithEndpoint(minioOptions["Endpoint"])
            .WithCredentials(minioOptions["AccessKey"], minioOptions["SecretKey"])
            .Build();
        _bucketName = minioOptions["BucketName"];
    }

    public async Task<bool> UploadFileAsync(string fileName, Stream fileStream)
    {
        try
        {
            await _minioClient.PutObjectAsync(new PutObjectArgs()
                .WithBucket(_bucketName)
                .WithObject(fileName)
                .WithStreamData(fileStream)
                .WithObjectSize(fileStream.Length)
                .WithContentType("application/octet-stream"));
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error uploading file: {ex.Message}");
            return false;
        }
    }
}
