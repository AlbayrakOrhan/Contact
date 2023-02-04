# Contact

Projeyi Onion architecture mimarisine göre desing etmeye çalıştım.Katmanlar ile ilgili kısaca bilgi vermek gerekirse;
 



 - `Contact.Domain`: Tüm uygulama için olan Domain ve veritabanı entity’leri bu katmanda oluşturulur.
 - `Contact.Application`: Bu katman, Domain katmanı ile uygulamanın business katmanı diyebileceğimiz arasında bir soyutlama katmanıdır.
 - `Contact.Infrastructure`: Sisteme eklenecek dış/external servisler bu katmanda konumlanır.
 - `Contact.Persistence`: DbContext, migration ve veritabanı konfigürasyon işlemleri bu katmanda gerçekleştirilir. 
 - `Contact.Api`: Kullanıcının uygulama ile iletişime geçtiği katmandır.


## Swagger

Projenin presentation katmanı olan Contact.Api projesi .Net 6 Web Api pojesidir ve endpointlerin designinde olabildiğince restful design yapmaya özen gösterdim.Routing düzenine bakıldığında hangi endpointin ne iş yapıyor olduğu anlaşılacaktır diye düşünüyorum.

Hızlıca görebilmeniz için ekran görüntüsü içeren bir link paylaşıyorum. 

https://drive.google.com/file/d/1Eu-G1OLQO9w7E9sHLlnkO5hVXzAMKuXf/view?usp=sharing

## Database

Uygulamada PostgreSql veritabanı kullandım. Ben postgre kurulumunu docker ile yaptım.Çalıştıracağınız ortama göre connectionString'i düzenlemeniz gerekecek. Ben connectionString'im şu şekilde.

```bash
  Host=localhost;Port=54320;Username=postgres;Password=testdb;Database=Contact
```

