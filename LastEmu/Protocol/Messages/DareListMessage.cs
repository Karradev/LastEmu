using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareListMessage : NetworkMessage
	{
		public const uint Id = 6661;

		public DareInformations[] dares;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6661;
			}
		}

		public DareListMessage()
		{
		}

		public DareListMessage(DareInformations[] dares)
		{
			this.dares = dares;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.dares = new DareInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.dares[i] = new DareInformations();
				this.dares[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.dares.Length));
			DareInformations[] dareInformationsArray = this.dares;
			for (int i = 0; i < (int)dareInformationsArray.Length; i++)
			{
				dareInformationsArray[i].Serialize(writer);
			}
		}
	}
}