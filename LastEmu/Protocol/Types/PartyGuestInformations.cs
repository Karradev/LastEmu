using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class PartyGuestInformations
	{
		public const short Id = 374;

		public double guestId;

		public double hostId;

		public string name;

		public EntityLook guestLook;

		public sbyte breed;

		public bool sex;

		public PlayerStatus status;

		public PartyCompanionBaseInformations[] companions;

		public virtual short TypeId
		{
			get
			{
				return 374;
			}
		}

		public PartyGuestInformations()
		{
		}

		public PartyGuestInformations(double guestId, double hostId, string name, EntityLook guestLook, sbyte breed, bool sex, PlayerStatus status, PartyCompanionBaseInformations[] companions)
		{
			this.guestId = guestId;
			this.hostId = hostId;
			this.name = name;
			this.guestLook = guestLook;
			this.breed = breed;
			this.sex = sex;
			this.status = status;
			this.companions = companions;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.guestId = reader.ReadVarUhLong();
			this.hostId = reader.ReadVarUhLong();
			this.name = reader.ReadUTF();
			this.guestLook = new EntityLook();
			this.guestLook.Deserialize(reader);
			this.breed = reader.ReadSByte();
			this.sex = reader.ReadBoolean();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.companions = new PartyCompanionBaseInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.companions[i] = new PartyCompanionBaseInformations();
				this.companions[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.guestId);
			writer.WriteVarLong(this.hostId);
			writer.WriteUTF(this.name);
			this.guestLook.Serialize(writer);
			writer.WriteSByte(this.breed);
			writer.WriteBoolean(this.sex);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
			writer.WriteShort((short)((int)this.companions.Length));
			PartyCompanionBaseInformations[] partyCompanionBaseInformationsArray = this.companions;
			for (int i = 0; i < (int)partyCompanionBaseInformationsArray.Length; i++)
			{
				partyCompanionBaseInformationsArray[i].Serialize(writer);
			}
		}
	}
}