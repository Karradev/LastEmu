using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountXpRatioMessage : NetworkMessage
	{
		public const uint Id = 5970;

		public sbyte ratio;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5970;
			}
		}

		public MountXpRatioMessage()
		{
		}

		public MountXpRatioMessage(sbyte ratio)
		{
			this.ratio = ratio;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.ratio = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.ratio);
		}
	}
}