using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountEquipedErrorMessage : NetworkMessage
	{
		public const uint Id = 5963;

		public sbyte errorType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5963;
			}
		}

		public MountEquipedErrorMessage()
		{
		}

		public MountEquipedErrorMessage(sbyte errorType)
		{
			this.errorType = errorType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.errorType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.errorType);
		}
	}
}