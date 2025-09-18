namespace Handler.Extensions
{
    public static class ImageHandler
    {
        public static async Task<string> ImageConverterAsync(IFormFile image)
        {
            if (image == null)
                return null;

            using var dataStream = new MemoryStream();
            await image.CopyToAsync(dataStream);  // Copy the image data into the memory stream

            byte[] imageBytes = dataStream.ToArray();  // Convert the stream to a byte array
            return Convert.ToBase64String(imageBytes);  // Convert the byte array to a Base64 string and return it
        }

    }
}


