using System;
using Confluent.Kafka;
namespace LunchPad_Scraper.Services
{
	public class KafkaConsumer
	{
		private ConsumerConfig config;
		private CancellationTokenSource cts;


		public KafkaConsumer( string bootstrapServers, string groupId)
		{
			config = new ConsumerConfig
			{
				BootstrapServers = bootstrapServers,
				GroupId = groupId,
				AutoOffsetReset = AutoOffsetReset.Earliest
			};

			cts = new CancellationTokenSource();
		}

		public void BeginConsume(string topic)
		{
			using (var consumer = new ConsumerBuilder<string, string>(config).Build())
			{
				consumer.Subscribe(topic);

				try {
				while (true)
					{
						var result = consumer.Consume(cts.Token);

					}

				}
				catch (OperationCanceledException)
				{
					//handle cancellation

				}
				finally
				{
                    consumer.Close();
				}
			}
		}


		public void EndConsuming()
		{
			cts.Cancel();
		}
	}
}

