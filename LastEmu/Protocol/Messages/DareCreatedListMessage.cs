using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareCreatedListMessage : NetworkMessage
	{
		public const uint Id = 6663;

		public DareInformations[] daresFixedInfos;

		public DareVersatileInformations[] daresVersatilesInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6663;
			}
		}

		public DareCreatedListMessage()
		{
		}

		public DareCreatedListMessage(DareInformations[] daresFixedInfos, DareVersatileInformations[] daresVersatilesInfos)
		{
			this.daresFixedInfos = daresFixedInfos;
			this.daresVersatilesInfos = daresVersatilesInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.daresFixedInfos = new DareInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.daresFixedInfos[i] = new DareInformations();
				this.daresFixedInfos[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.daresVersatilesInfos = new DareVersatileInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.daresVersatilesInfos[j] = new DareVersatileInformations();
				this.daresVersatilesInfos[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.daresFixedInfos.Length));
			DareInformations[] dareInformationsArray = this.daresFixedInfos;
			for (int i = 0; i < (int)dareInformationsArray.Length; i++)
			{
				dareInformationsArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.daresVersatilesInfos.Length));
			DareVersatileInformations[] dareVersatileInformationsArray = this.daresVersatilesInfos;
			for (int j = 0; j < (int)dareVersatileInformationsArray.Length; j++)
			{
				dareVersatileInformationsArray[j].Serialize(writer);
			}
		}
	}
}