using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicLatencyStatsMessage : NetworkMessage
	{
		public const uint Id = 5663;

		public ushort latency;

		public uint sampleCount;

		public uint max;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5663;
			}
		}

		public BasicLatencyStatsMessage()
		{
		}

		public BasicLatencyStatsMessage(ushort latency, uint sampleCount, uint max)
		{
			this.latency = latency;
			this.sampleCount = sampleCount;
			this.max = max;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.latency = reader.ReadUShort();
			this.sampleCount = reader.ReadVarUhShort();
			this.max = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(this.latency);
			writer.WriteVarShort((int)this.sampleCount);
			writer.WriteVarShort((int)this.max);
		}
	}
}