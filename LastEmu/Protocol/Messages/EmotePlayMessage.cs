using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class EmotePlayMessage : EmotePlayAbstractMessage
	{
		public const uint Id = 5683;

		public double actorId;

		public int accountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5683;
			}
		}

		public EmotePlayMessage()
		{
		}

		public EmotePlayMessage(byte emoteId, double emoteStartTime, double actorId, int accountId) : base(emoteId, emoteStartTime)
		{
			this.actorId = actorId;
			this.accountId = accountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.actorId = reader.ReadDouble();
			this.accountId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.actorId);
			writer.WriteInt(this.accountId);
		}
	}
}