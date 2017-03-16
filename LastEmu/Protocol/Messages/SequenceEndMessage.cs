using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SequenceEndMessage : NetworkMessage
	{
		public const uint Id = 956;

		public uint actionId;

		public double authorId;

		public sbyte sequenceType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)956;
			}
		}

		public SequenceEndMessage()
		{
		}

		public SequenceEndMessage(uint actionId, double authorId, sbyte sequenceType)
		{
			this.actionId = actionId;
			this.authorId = authorId;
			this.sequenceType = sequenceType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.actionId = reader.ReadVarUhShort();
			this.authorId = reader.ReadDouble();
			this.sequenceType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.actionId);
			writer.WriteDouble(this.authorId);
			writer.WriteSByte(this.sequenceType);
		}
	}
}