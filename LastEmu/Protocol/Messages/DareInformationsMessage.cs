using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareInformationsMessage : NetworkMessage
	{
		public const uint Id = 6656;

		public DareInformations dareFixedInfos;

		public DareVersatileInformations dareVersatilesInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6656;
			}
		}

		public DareInformationsMessage()
		{
		}

		public DareInformationsMessage(DareInformations dareFixedInfos, DareVersatileInformations dareVersatilesInfos)
		{
			this.dareFixedInfos = dareFixedInfos;
			this.dareVersatilesInfos = dareVersatilesInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dareFixedInfos = new DareInformations();
			this.dareFixedInfos.Deserialize(reader);
			this.dareVersatilesInfos = new DareVersatileInformations();
			this.dareVersatilesInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.dareFixedInfos.Serialize(writer);
			this.dareVersatilesInfos.Serialize(writer);
		}
	}
}