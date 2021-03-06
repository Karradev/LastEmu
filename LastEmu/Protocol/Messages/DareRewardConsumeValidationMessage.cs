using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareRewardConsumeValidationMessage : NetworkMessage
	{
		public const uint Id = 6675;

		public double dareId;

		public sbyte type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6675;
			}
		}

		public DareRewardConsumeValidationMessage()
		{
		}

		public DareRewardConsumeValidationMessage(double dareId, sbyte type)
		{
			this.dareId = dareId;
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dareId = reader.ReadDouble();
			this.type = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.dareId);
			writer.WriteSByte(this.type);
		}
	}
}