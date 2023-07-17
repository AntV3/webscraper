using System;
using Confluent.Kafka;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LunchPad_Scraper.Services
{
	public class KafkaProducer
	{
		private ProducerConfig config;

		public KafkaProducer(string bootstrapServers)
		{
			config = new ProducerConfig { BootstrapServers = bootstrapServers };

		}
		public void PublishMessage(string topic, string messgage)
		{
			using (var producer = new ProducerBuilder<string, string>(config).Build())
			{

				var result = producer.ProduceAsync(topic, new Message<string, string> { Key = null, Value = messgage }) Results;
			}
		}
	}
}

