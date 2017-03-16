using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class IdolsPreset
	{
		public const short Id = 491;

		public sbyte presetId;

		public sbyte symbolId;

		public uint[] idolId;

		public virtual short TypeId
		{
			get
			{
				return 491;
			}
		}

		public IdolsPreset()
		{
		}

		public IdolsPreset(sbyte presetId, sbyte symbolId, uint[] idolId)
		{
			this.presetId = presetId;
			this.symbolId = symbolId;
			this.idolId = idolId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.symbolId = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.idolId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.idolId[i] = reader.ReadVarUhShort();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.symbolId);
			writer.WriteShort((short)((int)this.idolId.Length));
			uint[] numArray = this.idolId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}