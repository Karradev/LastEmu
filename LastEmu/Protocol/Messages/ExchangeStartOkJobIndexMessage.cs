using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkJobIndexMessage : NetworkMessage
	{
		public const uint Id = 5819;

		public uint[] jobs;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5819;
			}
		}

		public ExchangeStartOkJobIndexMessage()
		{
		}

		public ExchangeStartOkJobIndexMessage(uint[] jobs)
		{
			this.jobs = jobs;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.jobs = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.jobs[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.jobs.Length));
			uint[] numArray = this.jobs;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}