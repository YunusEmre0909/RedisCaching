using StackExchange.Redis;

ConnectionMultiplexer redis = await ConnectionMultiplexer.ConnectAsync("localhost:1453");
ISubscriber subscriber = redis.GetSubscriber();
await subscriber.SubscribeAsync("my.*", (channel, message) =>
{
    Console.WriteLine(message);
});
Console.ReadLine();