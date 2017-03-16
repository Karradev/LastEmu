using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InventoryPresetItemUpdateErrorMessage : NetworkMessage
	{
		public const uint Id = 6211;

		public sbyte code;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6211;
			}
		}

		public InventoryPresetItemUpdateErrorMessage()
		{
		}

		public InventoryPresetItemUpdateErrorMessage(sbyte code)
		{
			this.code = code;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.code = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.code);
		}
	}
}