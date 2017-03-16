using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionTitle : HumanOption
	{
		public const short Id = 408;

		public uint titleId;

		public string titleParam;

		public override short TypeId
		{
			get
			{
				return 408;
			}
		}

		public HumanOptionTitle()
		{
		}

		public HumanOptionTitle(uint titleId, string titleParam)
		{
			this.titleId = titleId;
			this.titleParam = titleParam;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.titleId = reader.ReadVarUhShort();
			this.titleParam = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.titleId);
			writer.WriteUTF(this.titleParam);
		}
	}
}