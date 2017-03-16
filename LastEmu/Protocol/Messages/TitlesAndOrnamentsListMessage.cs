using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitlesAndOrnamentsListMessage : NetworkMessage
	{
		public const uint Id = 6367;

		public uint[] titles;

		public uint[] ornaments;

		public uint activeTitle;

		public uint activeOrnament;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6367;
			}
		}

		public TitlesAndOrnamentsListMessage()
		{
		}

		public TitlesAndOrnamentsListMessage(uint[] titles, uint[] ornaments, uint activeTitle, uint activeOrnament)
		{
			this.titles = titles;
			this.ornaments = ornaments;
			this.activeTitle = activeTitle;
			this.activeOrnament = activeOrnament;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.titles = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.titles[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.ornaments = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.ornaments[j] = reader.ReadVarUhShort();
			}
			this.activeTitle = reader.ReadVarUhShort();
			this.activeOrnament = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.titles.Length));
			uint[] numArray = this.titles;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.ornaments.Length));
			uint[] numArray1 = this.ornaments;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
			writer.WriteVarShort((int)this.activeTitle);
			writer.WriteVarShort((int)this.activeOrnament);
		}
	}
}