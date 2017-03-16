using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareVersatileListMessage : NetworkMessage
	{
		public const uint Id = 6657;

		public DareVersatileInformations[] dares;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6657;
			}
		}

		public DareVersatileListMessage()
		{
		}

		public DareVersatileListMessage(DareVersatileInformations[] dares)
		{
			this.dares = dares;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.dares = new DareVersatileInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.dares[i] = new DareVersatileInformations();
				this.dares[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.dares.Length));
			DareVersatileInformations[] dareVersatileInformationsArray = this.dares;
			for (int i = 0; i < (int)dareVersatileInformationsArray.Length; i++)
			{
				dareVersatileInformationsArray[i].Serialize(writer);
			}
		}
	}
}