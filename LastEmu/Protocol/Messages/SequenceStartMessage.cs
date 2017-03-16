using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SequenceStartMessage : NetworkMessage
	{
		public const uint Id = 955;

		public sbyte sequenceType;

		public double authorId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)955;
			}
		}

		public SequenceStartMessage()
		{
		}

		public SequenceStartMessage(sbyte sequenceType, double authorId)
		{
			this.sequenceType = sequenceType;
			this.authorId = authorId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.sequenceType = reader.ReadSByte();
			this.authorId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.sequenceType);
			writer.WriteDouble(this.authorId);
		}
	}
}