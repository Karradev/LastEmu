using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolsPresetUseResultMessage : NetworkMessage
	{
		public const uint Id = 6614;

		public sbyte presetId;

		public sbyte code;

		public uint[] missingIdols;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6614;
			}
		}

		public IdolsPresetUseResultMessage()
		{
		}

		public IdolsPresetUseResultMessage(sbyte presetId, sbyte code, uint[] missingIdols)
		{
			this.presetId = presetId;
			this.code = code;
			this.missingIdols = missingIdols;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.code = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.missingIdols = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.missingIdols[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.code);
			writer.WriteShort((short)((int)this.missingIdols.Length));
			uint[] numArray = this.missingIdols;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}