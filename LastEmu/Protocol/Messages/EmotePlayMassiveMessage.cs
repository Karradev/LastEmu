using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
	{
		public const uint Id = 5691;

		public double[] actorIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5691;
			}
		}

		public EmotePlayMassiveMessage()
		{
		}

		public EmotePlayMassiveMessage(byte emoteId, double emoteStartTime, double[] actorIds) : base(emoteId, emoteStartTime)
		{
			this.actorIds = actorIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.actorIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.actorIds[i] = reader.ReadDouble();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.actorIds.Length));
			double[] numArray = this.actorIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
		}
	}
}