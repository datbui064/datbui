using Minio;
using Minio.DataModel.Args;

public class FileService
{
    private readonly MinioClient _minioClient;


    public FileService()
    {
        _minioClient = (MinioClient)new MinioClient()
            .WithEndpoint("localhost:9000") // e.g., "localhost:9000"
            .WithCredentials("datbui", "123456789")
           
            .Build();
    }

    public async Task UploadFileAsync(string fileName, byte[] fileData)
    {
        using var stream = new MemoryStream(fileData);
        var putObjectArgs = new PutObjectArgs()
            .WithBucket("your-bucket-name")
            .WithObject(fileName)
            .WithStreamData(stream)
            .WithObjectSize(stream.Length)
            .WithContentType("application/octet-stream");
        await _minioClient.PutObjectAsync(putObjectArgs);
    }
}
